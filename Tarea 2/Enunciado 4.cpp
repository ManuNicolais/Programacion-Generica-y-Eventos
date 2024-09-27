//4. 4.	Crear una clase Animal con métodos como comer y dormir y luego crear clases como Perro y Gato que hereden de Animal y tengan métodos específicos como ladrar y maullar.
#include <iostream>
#include <string>

using namespace std;

class Animal {
    public:
        void comer() {
            cout << "Comiendo..." << endl;
        }
        void dormir() {
            cout << "Durmiendo..." << endl;
        }
};

class Perro : public Animal {
    public:
        void ladrar() {
            cout << "Ladrando..." << endl;
        }
};

class Gato : public Animal {
    public:
        void maullar() {
            cout << "Maullando..." << endl;
        }
};

int main() {
    Perro perro;
    Gato gato;
    cout << "Perro:" << endl;
    perro.comer();
    perro.dormir();
    perro.ladrar();

    cout << "Gato:" << endl;
    gato.comer();
    gato.dormir();
    gato.maullar();

    return 0;
}