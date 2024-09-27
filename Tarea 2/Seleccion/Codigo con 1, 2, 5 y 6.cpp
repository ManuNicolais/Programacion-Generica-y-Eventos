#include <iostream>
#include <cstdlib> // Para usar rand() y srand()
#include <ctime> // Para inicializar srand()
#include "Enunciado 1.h" // Contiene clase Persona y Empleado
#include "Enunciado 2.h" // Contiene clase Vehiculo y Coche
#include "Enunciado 5.h" // Contiene clase Estudiante y Grupo
#include "Enunciado 6.h" // Contiene clase CuentaBancaria, CuentaCorriente y CuentaAhorro

using namespace std;

void separador() {
    cout << "--------------------------------" << endl;
}

// Unir los 4 enunciados en un solo menú
void Menu(Empleado& empleado, Coche& coche, Grupo& grupo, CuentaCorriente& cuentaCorriente, Estudiante& estudiante) {
    srand(time(0)); // Inicializar rand() con la hora actual
    int random = rand() % 80 + 1; // Generar un número aleatorio entre 1 y 80

    int opcion = 0;

    while (opcion != 6) {
        cout << "Menu de empresa" << endl;
        cout << "1. Registrate como empleado" << endl;
        cout << "2. Registra tu auto en la Cochera" << endl;
        cout << "3. Registrate como estudiante de nuestros cursos" << endl;
        cout << "4. Cuenta bancaria" << endl;
        cout << "5. Mostrar Datos" << endl;
        cout << "6. Salir" << endl;

        cout << "Ingrese una opcion: ";
        cin >> opcion;

        switch (opcion) {
            case 1: {
                string nombre, genero, cargo;
                int edad;
                float salario;

                cout << "Ingrese el nombre del empleado: ";
                cin >> nombre;
                cout << "Ingrese la edad del empleado: ";
                cin >> edad;
                cout << "Ingrese el genero del empleado: ";
                cin >> genero;
                cout << "Ingrese el salario del empleado: ";
                cin >> salario;
                cout << "Ingrese el cargo del empleado: ";
                cin >> cargo;

                empleado = Empleado(nombre, edad, genero, salario, cargo);

                cout << "Empleado registrado con exito" << endl;
                separador();
                break;
            }
            case 2: {
                string marca, modelo, color;
                int anio, puertas;

                cout << "Ingrese la marca del coche: ";
                cin >> marca;
                cout << "Ingrese el modelo del coche: ";
                cin >> modelo;
                cout << "Ingrese el anio del coche: ";
                cin >> anio;
                cout << "Ingrese la cantidad de puertas del coche: ";
                cin >> puertas;

                coche = Coche(marca, modelo, anio, puertas);

                cout << "Coche registrado con exito" << endl;
                cout << "Se te ha asignado el lugar " << random << " de la cochera" << endl;
                separador();
                break;
            }
            case 3: {
                string nombre;
                int edad;
                float nota;

                cout << "Ingrese el nombre del estudiante: ";
                cin >> nombre;
                cout << "Ingrese la edad del estudiante: ";
                cin >> edad;
                cout << "Ingrese la nota del estudiante: ";
                cin >> nota;

                estudiante = Estudiante(nombre, edad, nota);
                grupo.setEstudiante(grupo.getNumEstudiantes(), estudiante);
                cout << "Felicidades, eres el estudiante numero " << grupo.getNumEstudiantes() << endl;

                cout << "Estudiante registrado con exito" << endl;
                separador();
                break;
            }
            case 4: {
                float saldo;
                string numeroCuenta;

                cout << "Ingrese el saldo de la cuenta: ";
                cin >> saldo;
                cout << "Ingrese el numero de cuenta: ";
                cin >> numeroCuenta;

                cuentaCorriente = CuentaCorriente(saldo, numeroCuenta);

                cout << "Cuenta corriente registrada con exito" << endl;
                separador();
                break;
            }
            case 5: {
                // Mostrar datos de los objetos
                cout << "Datos del Empleado:" << endl;
                cout << "Nombre: " << empleado.getNombre() << endl;
                cout << "Edad: " << empleado.getEdad() << endl;
                cout << "Genero: " << empleado.getGenero() << endl;
                cout << "Saldo: " << empleado.getSalario() << endl;
                cout << "Cargo: " << empleado.getCargo() << endl;

                separador();

                cout << "Datos del Coche:" << endl;
                cout << "Marca: " << coche.getMarca() << endl;
                cout << "Modelo: " << coche.getModelo() << endl;
                cout << "Anio: " << coche.getAnio() << endl;
                cout << "Numero de puertas: " << coche.getNumPuertas() << endl;

                separador();

                cout << "Datos del Grupo de Estudiantes:" << endl;
                cout << "Promedio de notas: " << estudiante.getNota() << endl;
                cout << "Cantidad de estudiantes: " << grupo.getNumEstudiantes() << endl;

                separador();

                cout << "Datos de la Cuenta Corriente:" << endl;
                cout << "Saldo: " << cuentaCorriente.getSaldo() << endl;
                cout << "Numero de cuenta: " << cuentaCorriente.getNumeroCuenta() << endl;

                separador();
                break;
            }
            case 6: {
                cout << "Saliendo..." << endl;
                break;
            }
            default:
                cout << "Opción no válida." << endl;
                break;
        }
    }
}

int main() {
    // Crear objetos vacíos para pasarlos al menú
    Empleado empleado; 
    Coche coche; 
    Grupo grupo;
    CuentaCorriente cuentaCorriente;
    Estudiante estudiante;

    Menu(empleado, coche, grupo, cuentaCorriente, estudiante);
    return 0;
}
