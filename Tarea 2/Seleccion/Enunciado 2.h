// 2. 2.	Crear una clase Vehículo con atributos como marca, modelo, año, etc. y luego crear una clase Coche y una clase Moto que hereden de Vehículo y tengan atributos específicos como número de puertas, cilindrada, etc.

#include <iostream>
#include <string>
using namespace std;

class Vehiculo {
    private:
        string marca;
        string modelo;
        int anio;

    public:
        Vehiculo(string marca, string modelo, int anio) {
            this->marca = marca;
            this->modelo = modelo;
            this->anio = anio;
        }
        string getMarca() {
            return marca;
        }
        string getModelo() {
            return modelo;
        }
        int getAnio() {
            return anio;
        }
        void setMarca(string marca) {
            this->marca = marca;
        }
        void setModelo(string modelo) {
            this->modelo = modelo;
        }
        void setAnio(int anio) {
            this->anio = anio;
        }
};

class Coche : public Vehiculo {
    private:
        int numPuertas;

    public:
        Coche() : Vehiculo("", "", 0) {
            numPuertas = 0;
        }

        Coche(string marca, string modelo, int anio, int numPuertas) : Vehiculo(marca, modelo, anio) {
            this->numPuertas = numPuertas;
        }
        int getNumPuertas() {
            return numPuertas;
        }
        void setNumPuertas(int numPuertas) {
            this->numPuertas = numPuertas;
        }
};

