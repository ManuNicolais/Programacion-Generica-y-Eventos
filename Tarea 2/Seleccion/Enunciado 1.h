// 1.	Crear una clase Persona con atributos como nombre, edad, género, etc. y luego crear una clase Empleado que herede de Persona y tenga atributos como salario, cargo, etc.

#include <iostream>
#include <string>
using namespace std;

class Persona {
    private:
        string nombre;
        int edad;
        string genero;

    public:
        Persona(string nombre, int edad, string genero) {
            this->nombre = nombre;
            this->edad = edad;
            this->genero = genero;
        }

        Persona() {
            nombre = "";
            edad = 0;
            genero = "";
        }

        string getNombre() {
            return nombre;
        }
        int getEdad() {
            return edad;
        }
        string getGenero() {
            return genero;
        }
        void setNombre(string nombre) {
            this->nombre = nombre;
        }
        void setEdad(int edad) {
            this->edad = edad;
        }
        void setGenero(string genero) {
            this->genero = genero;
        }
};

class Empleado : public Persona {
    private:
        float salario;
        string cargo;

    public:
        Empleado() : Persona("", 0, "") {
            salario = 0;
            cargo = "";
        }

        Empleado(string nombre, int edad, string genero, float salario, string cargo) : Persona(nombre, edad, genero) {
            this->salario = salario;
            this->cargo = cargo;
        }
        float getSalario() {
            return salario;
        }
        string getCargo() {
            return cargo;
        }
        void setSalario(float salario) {
            this->salario = salario;
        }
        void setCargo(string cargo) {
            this->cargo = cargo;
        }
};


