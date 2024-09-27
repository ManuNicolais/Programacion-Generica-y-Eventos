//9.	Crear una clase Persona con atributos como nombre, edad, género, etc. y luego crear una clase Trabajador que tenga un objeto 
//Persona y un método para calcular su salario según su cargo y otras variables.

#include <iostream>
using namespace std;

class Persona {
    private:
        string nombre;
        int edad;
        string genero;
        string cargo;
        float salario;

    public:
        Persona(string nombre, int edad, string genero, string cargo, float salario){
            this->nombre = nombre;
            this->edad = edad;
            this->genero = genero;
            this->cargo = cargo;
            this->salario = salario;
        }

        void setNombre(string nombre){
            this->nombre = nombre;
        }
        string getNombre(){
            return nombre;
        }
        void setEdad(int edad){
            this->edad = edad;
        }
        int getEdad(){
            return edad;
        }
        void setGenero(string genero){
            this->genero = genero;
        }
        string getGenero(){
            return genero;
        }
        void setCargo(string cargo){
            this->cargo = cargo;
        }
        string getCargo(){
            return cargo;
        }
        void setSalario(float salario){
            this->salario = salario;
        }
        float getSalario(){
            return salario;
        }

};

class Trabajador :public Persona {
    public:
        Trabajador(string nombre, int edad, string genero, string cargo, float salario) : Persona(nombre, edad, genero, cargo, salario) {}

        void calcularSalario(){
            float salario = getSalario();
            if(getCargo() == "Gerente"){
                setSalario(salario + (salario * 0.1));//Se calcula un bono del 10% como ejemplo
            } else if(getCargo() == "Supervisor"){
                setSalario(salario + (salario * 0.05));//Se calcula un bono del 5% como ejemplo
            } else {
                setSalario(salario + (salario * 0.03));//Se calcula un bono del 3% como ejemplo
            }
        }
};

int main(){
    Trabajador trabajador("Juan", 25, "Masculino", "Gerente", 1000.0);
    cout << "Salario del trabajador: " << trabajador.getSalario() << endl;
    trabajador.calcularSalario();
    cout << "Salario del trabajador después de calcular salario: " << trabajador.getSalario() << endl;

    return 0;
}