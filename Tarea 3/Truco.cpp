#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <random>
#include <ctime>
#include <map>
#include <thread>
#include <chrono>

using namespace std;


// Clase Carta  ---------------------------------------------------------------------------------------------
class Carta
{
public:
    string palo;
    int valor;

    Carta(const string &p, int v) : palo(p), valor(v) {}

    static int comparar(const Carta &carta1, const Carta &carta2)
    {
        static const map<string, map<int, int>> jerarquia = {
            {"Espada", {{1, 14}, {2, 9}, {3, 10}, {4, 1}, {5, 2}, {6, 3}, {7, 12}, {10, 4}, {11, 5}, {12, 6}}},
            {"Basto", {{1, 13}, {2, 9}, {3, 10}, {4, 1}, {5, 2}, {6, 3}, {7, 11}, {10, 4}, {11, 5}, {12, 6}}},
            {"Oro", {{1, 8}, {2, 9}, {3, 10}, {4, 1}, {5, 2}, {6, 3}, {7, 7}, {10, 4}, {11, 5}, {12, 6}}},
            {"Copa", {{1, 8}, {2, 9}, {3, 10}, {4, 1}, {5, 2}, {6, 3}, {7, 7}, {10, 4}, {11, 5}, {12, 6}}}};

        return (jerarquia.at(carta1.palo).at(carta1.valor) > jerarquia.at(carta2.palo).at(carta2.valor)) -
               (jerarquia.at(carta1.palo).at(carta1.valor) < jerarquia.at(carta2.palo).at(carta2.valor));
    }
};

// Clase Mazo ---------------------------------------------------------------------------------------------
class Mazo
{
private:
    vector<Carta> cartas;

public:
    Mazo()
    {
        vector<string> palos = {"Espada", "Basto", "Oro", "Copa"};
        for (const auto &palo : palos)
        {
            for (int valor = 1; valor <= 12; ++valor)
            {
                if (valor != 8 && valor != 9)
                {
                    cartas.emplace_back(palo, valor);
                }
            }
        }
        shuffle(cartas.begin(), cartas.end(), default_random_engine(time(0)));
    }

    Carta repartirCarta()
    {
        Carta carta = cartas.back();
        cartas.pop_back();
        return carta;
    }
};

// Clase Jugador ---------------------------------------------------------------------------------------------
class Jugador
{
private:
    string nombre;
    vector<Carta> mano;
    int puntos;

public:
    Jugador(const string &n) : nombre(n), puntos(0) {}

    void recibirCarta(const Carta &carta) { mano.push_back(carta); }

    void mostrarMano() const
    {
        cout << "Mano de " << nombre << ":\n";
        for (size_t i = 0; i < mano.size(); ++i)
        {
            cout << i + 1 << ". " << mano[i].valor << " de " << mano[i].palo << "\n";
        }
        cout << endl;
    }

    Carta jugarCarta(int indice)
    {
        if (indice < 1 || indice > mano.size())
        {
            cerr << "Índice de carta inválido!" << endl;
            return Carta("Invalida", 0);
        }
        Carta cartaJugando = mano[indice - 1];
        mano.erase(mano.begin() + (indice - 1));
        cout << nombre << " ha jugado el " << cartaJugando.valor << " de " << cartaJugando.palo << endl;
        return cartaJugando;
    }

    int calcularPuntoscantarEnvido() const
    {
        map<int, int> puntosEnvido = {{1, 1}, {2, 2}, {3, 3}, {4, 4}, {5, 5}, {6, 6}, {7, 7}, {10, 0}, {11, 0}, {12, 0}};
        int maxPuntos = 0;

        for (size_t i = 0; i < mano.size(); ++i)
        {
            for (size_t j = i + 1; j < mano.size(); ++j)
            {
                if (mano[i].palo == mano[j].palo)
                {
                    maxPuntos = max(maxPuntos, 20 + puntosEnvido[mano[i].valor] + puntosEnvido[mano[j].valor]);
                }
            }
        }

        if (maxPuntos == 0)
        {
            for (const auto &carta : mano)
            {
                maxPuntos = max(maxPuntos, puntosEnvido[carta.valor]);
            }
        }

        return maxPuntos;
    }

    void sumarPuntos(int puntosGanados) { puntos += puntosGanados; }
    int getPuntos() const { return puntos; }
    string getNombre() const { return nombre; }
    void limpiarMano() { mano.clear(); }
};

void separador()
{
    cout << "----------------------------------------" << endl;
}


void menuOpcion(const string &opcion, Jugador &jugadorCanta, Jugador &jugadorResponde)
{
    cout << jugadorCanta.getNombre() << " ha cantado " << opcion << "!\n";
    cout << jugadorResponde.getNombre() << ", elige una opción:\n"
         << "1. Aceptar\n"
         << "2. No aceptar\n"
         << "Seleccione una opción: ";
}

// Función de callback -------------------------------------------------------------------------------------

void CallBackPuntos(Jugador &jugador1, Jugador &jugador2)
{
    cout << jugador1.getNombre() << " tiene " << jugador1.getPuntos() << " puntos.\n";
    cout << jugador2.getNombre() << " tiene " << jugador2.getPuntos() << " puntos.\n";
}

// Clase Juego ---------------------------------------------------------------------------------------------
class Juego
{
private:
    Jugador jugador1;
    Jugador jugador2;
    Mazo mazo;

    void mostrarPuntos(int puntosSumar, int jugador, void (*callback)(Jugador &, Jugador &))
    {
        if (jugador == 1)
        {
            jugador1.sumarPuntos(puntosSumar);
        }
        else
        {
            jugador2.sumarPuntos(puntosSumar);
        }
        callback(jugador1, jugador2);
        separador();
    }

    void repartirCartas()
    {
        cout << "Barajando cartas..." << endl;
        this_thread::sleep_for(chrono::seconds(1)); // hace un tiempo de espera de 1 segundo

        for (int i = 0; i < 3; i++)
        { // reparte cartas
            jugador1.recibirCarta(mazo.repartirCarta());
            jugador2.recibirCarta(mazo.repartirCarta());
        }

        cout << "Cartas repartidas." << endl;
        separador();
    }

    void gestionarEnvido(int ronda) {
        int cantarEnvido, respuesta;
        bool envidoCantado = false;

        // Primero pregunta al jugador 1
        cout << jugador1.getNombre() << ", quieres cantar Envido? (1. Sí, 2. No): ";
        cin >> cantarEnvido;

        if (cantarEnvido == 1) {
            envidoCantado = true;
            menuOpcion("Envido", jugador1, jugador2);
            cin >> respuesta;
            if (respuesta == 1) {
                evaluarEnvido(jugador1, jugador2);
            } else {
                cout << jugador2.getNombre() << " no acepta el Envido. " << jugador1.getNombre() << " gana 1 punto.\n";
                mostrarPuntos(1, 1, CallBackPuntos);
            }
        }

        // Si el jugador 1 no canta envido, pregunta al jugador 2
        if (!envidoCantado) {
            cout << jugador2.getNombre() << ", quieres cantar Envido? (1. Sí, 2. No): ";
            cin >> cantarEnvido;

            if (cantarEnvido == 1) {
                menuOpcion("Envido", jugador2, jugador1);
                cin >> respuesta;
                if (respuesta == 1) {
                    evaluarEnvido(jugador2, jugador1);
                } else {
                    cout << jugador1.getNombre() << " no acepta el Envido. " << jugador2.getNombre() << " gana 1 punto.\n";
                    mostrarPuntos(1, 2, CallBackPuntos);
                }
            } else {
                cout << "No se cantó Envido.\n";
            }
        }
    }

    void evaluarEnvido(Jugador& jugadorCanta, Jugador& jugadorResponde) {
        int puntosCanta = jugadorCanta.calcularPuntoscantarEnvido();
        int puntosResponde = jugadorResponde.calcularPuntoscantarEnvido();

        cout << jugadorCanta.getNombre() << " tiene " << puntosCanta << " puntos de Envido.\n";
        cout << jugadorResponde.getNombre() << " tiene " << puntosResponde << " puntos de Envido.\n";

        if (puntosCanta > puntosResponde) {
            cout << jugadorCanta.getNombre() << " gana el Envido!\n";
            mostrarPuntos(2, (jugadorCanta.getNombre() == jugador1.getNombre() ? 1 : 2), CallBackPuntos);
        } else if (puntosResponde > puntosCanta) {
            cout << jugadorResponde.getNombre() << " gana el Envido!\n";
            mostrarPuntos(2, (jugadorResponde.getNombre() == jugador1.getNombre() ? 1 : 2), CallBackPuntos);
        } else {
            cout << "Empate en el Envido!\n";
        }
    }


public:
    Juego(const string &nombre1, const string &nombre2) : jugador1(nombre1), jugador2(nombre2), mazo() {}

    void iniciar()
    {
        cout << "Iniciando juego entre " << jugador1.getNombre() << " y " << jugador2.getNombre() << endl;
        while (jugador1.getPuntos() < 30 && jugador2.getPuntos() < 30) {
            jugarRonda();
        }

        if (jugador1.getPuntos() >= 30) {
            cout << "\n" << jugador1.getNombre() << " ha ganado el juego con " << jugador1.getPuntos() << " puntos!\n";
        } else {
            cout << "\n" << jugador2.getNombre() << " ha ganado el juego con " << jugador2.getPuntos() << " puntos!\n";
        }
    }

    void jugarRonda()
    {
        bool turnoJugador1 = true;
        int manoGanadaJugador1 = 0, manoGanadaJugador2 = 0;

        repartirCartas();

        for (int ronda = 1; ronda <= 3; ronda++)
        {
            cout << "\nRonda " << ronda << endl;
            jugador1.mostrarMano();
            jugador2.mostrarMano();

            if (ronda == 1)
            {
                gestionarEnvido(ronda);
            }

            cout << jugador1.getNombre() << ", selecciona una carta para jugar: ";
            int indice1;
            cin >> indice1;
            Carta cartaJugador1 = jugador1.jugarCarta(indice1);

            cout << jugador2.getNombre() << ", selecciona una carta para jugar: ";
            int indice2;
            cin >> indice2;
            Carta cartaJugador2 = jugador2.jugarCarta(indice2);

            int resultado = Carta::comparar(cartaJugador1, cartaJugador2);
            if (resultado == 1)
            {
                cout << jugador1.getNombre() << " gana la mano " << ronda << "!\n";
                manoGanadaJugador1++;
            }
            else if (resultado == -1)
            {
                cout << jugador2.getNombre() << " gana la mano " << ronda << "!\n";
                manoGanadaJugador2++;
            }
            else
            {
                cout << "La mano " << ronda << " es un empate!\n";
            }

            if (manoGanadaJugador1 == 2)
            {
                cout << "\n"
                     << jugador1.getNombre() << " gana la ronda!\n";
                mostrarPuntos(2, 1, CallBackPuntos);
                break;
            }
            else if (manoGanadaJugador2 == 2)
            {
                cout << "\n"
                     << jugador2.getNombre() << " gana la ronda!\n";
                mostrarPuntos(2, 2, CallBackPuntos);
                break;
            }
        }

        jugador1.limpiarMano();
        jugador2.limpiarMano();
        separador();
    }
};

int main()
{
    string nombreJugador1, nombreJugador2;
    cout << "Ingrese el nombre del Jugador 1: ";
    cin >> nombreJugador1;
    cout << "Ingrese el nombre del Jugador 2: ";
    cin >> nombreJugador2;

    Juego juego(nombreJugador1, nombreJugador2);    
    juego.iniciar();     

    return 0;
}

