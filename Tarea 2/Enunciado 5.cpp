//5. 5.	Crear una clase Estudiante con atributos como nombre, edad, nota, etc. y luego crear una clase Grupo que tenga un arreglo de objetos Estudiante y métodos para calcular el promedio de notas del grupo.

#include <iostream>
#include <string>
using namespace std;

class Estudiante {
    private:
        string nombre;
        int edad;
        float nota;

    public:
        // Constructor por defecto
        Estudiante() : nombre(""), edad(0), nota(0.0) {}

        // Constructor parametrizado
        Estudiante(string nombre, int edad, float nota) {
            this->nombre = nombre;
            this->edad = edad;
            this->nota = nota;
        }

        // Getters
        string getNombre() {
            return nombre;
        }

        int getEdad() {
            return edad;
        }

        float getNota() {
            return nota;
        }

        // Setters
        void setNombre(string nombre) {
            this->nombre = nombre;
        }

        void setEdad(int edad) {
            this->edad = edad;
        }

        void setNota(float nota) {
            this->nota = nota;
        }
};

class Grupo {
    private:
        Estudiante* estudiantes;
        int numEstudiantes;

    public:
        // Constructor
        Grupo(int numEstudiantes) {
            this->numEstudiantes = numEstudiantes;
            estudiantes = new Estudiante[numEstudiantes];
        }

        // Destructor
        ~Grupo() {
            delete[] estudiantes;
        }

        // Setear estudiante en la posición i
        void setEstudiante(int i, Estudiante estudiante) {
            if (i >= 0 && i < numEstudiantes) {
                estudiantes[i] = estudiante;
            } else {
                cout << "Índice fuera de rango." << endl;
            }
        }

        // Calcular promedio de notas
        float calcularPromedio() {
            float suma = 0;
            for (int i = 0; i < numEstudiantes; i++) {
                suma += estudiantes[i].getNota();
            }
            return suma / numEstudiantes;
        }
};

int main() {
    Grupo grupo(3);

    Estudiante estudiante1("Juan", 20, 15.5);
    Estudiante estudiante2("Maria", 21, 16.0);
    Estudiante estudiante3("Pedro", 22, 14.0);

    grupo.setEstudiante(0, estudiante1);
    grupo.setEstudiante(1, estudiante2);
    grupo.setEstudiante(2, estudiante3);

    cout << "Promedio de notas: " << grupo.calcularPromedio() << endl;

    return 0;
}
