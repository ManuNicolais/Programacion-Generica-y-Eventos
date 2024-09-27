//8.	Crear una clase Película con atributos como título, director, género, etc. y luego crear una clase Alquiler 
//que tenga un objeto Película y métodos para calcular el costo del alquiler según la duración y otros factores.

#include <iostream>
using namespace std;

class Pelicula {
    private:
        string titulo;
        string director;
        string genero;
        int duracion;
        float precio;

    public:
        Pelicula(string titulo, string director, string genero, int duracion, float precio){
            this->titulo = titulo;
            this->director = director;
            this->genero = genero;
            this->duracion = duracion;
            this->precio = precio;
        }

        void setTitulo(string titulo){
            this->titulo = titulo;
        }
        string getTitulo(){
            return titulo;
        }
        void setDirector(string director){
            this->director = director;
        }
        string getDirector(){
            return director;
        }
        void setGenero(string genero){
            this->genero = genero;
        }
        string getGenero(){
            return genero;
        }
        void setDuracion(int duracion){
            this->duracion = duracion;
        }
        int getDuracion(){
            return duracion;
        }
        void setPrecio(float precio){
            this->precio = precio;
        }
        float getPrecio(){
            return precio;
        }

};

class Alquiler :public Pelicula {
    public:
        Alquiler(string titulo, string director, string genero, int duracion, float precio) : Pelicula(titulo, director, genero, duracion, precio) {}

        float calcularCosto(int duracion){
            float precio = getPrecio();
            return precio * duracion;
        }
};

int main(){
    Alquiler alquiler("El Padrino", "Francis Ford Coppola", "Drama", 175, 5.0);
    cout << "Costo del alquiler: " << alquiler.calcularCosto(3) << endl;
    return 0;
}