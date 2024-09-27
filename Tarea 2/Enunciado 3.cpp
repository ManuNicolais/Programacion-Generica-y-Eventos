// 3. 3.	Crear una clase FiguraGeometrica con atributos como área y perímetro y luego crear clases como Triángulo, Cuadrado y Círculo que hereden de FiguraGeometrica y tengan métodos específicos para calcular su área y perímetro.

#include <iostream>
#include <cmath>

using namespace std;

class FiguraGeometrica {
    protected:
        float area;
        float perimetro;

    public:
        FiguraGeometrica(float area, float perimetro) {
            this->area = area;
            this->perimetro = perimetro;
        }
        float getArea() {
            return area;
        }
        float getPerimetro() {
            return perimetro;
        }
        void setArea(float area) {
            this->area = area;
        }
        void setPerimetro(float perimetro) {
            this->perimetro = perimetro;
        }
};

class Triangulo : public FiguraGeometrica {
    private:
        float base;
        float altura;

    public:
        Triangulo(float base, float altura) : FiguraGeometrica(0, 0) {
            this->base = base;
            this->altura = altura;
        }
        void calcularArea() {
            area = (base * altura) / 2;
        }
        void calcularPerimetro() {
            perimetro = base + altura + sqrt((base*base) + (altura*altura));
        }
};

class Cuadrado : public FiguraGeometrica {
    private:
        float lado;

    public:
        Cuadrado(float lado) : FiguraGeometrica(0, 0) {
            this->lado = lado;
        }
        void calcularArea() {
            area = (lado * lado);
        }
        void calcularPerimetro() {
            perimetro = 4 * lado;
        }
};

class Circulo : public FiguraGeometrica {
    private:
        float radio;

    public:
        Circulo(float radio) : FiguraGeometrica(0, 0) {
            this->radio = radio;
        }
        void calcularArea() {
            area = 3.1416 * (radio*radio);
        }
        void calcularPerimetro() {
            perimetro = 2 * 3.1416 * radio;
        }
};

int main(){
    Triangulo triangulo(5, 3);
    triangulo.calcularArea();
    triangulo.calcularPerimetro();
    cout << "Triangulo" << endl;
    cout << "Área: " << triangulo.getArea() << endl;
    cout << "Perímetro: " << triangulo.getPerimetro() << endl;

    Cuadrado cuadrado(4);
    cuadrado.calcularArea();
    cuadrado.calcularPerimetro();
    cout << "Cuadrado" << endl;
    cout << "Área: " << cuadrado.getArea() << endl;
    cout << "Perímetro: " << cuadrado.getPerimetro() << endl;

    Circulo circulo(3);
    circulo.calcularArea();
    circulo.calcularPerimetro();
    cout << "Círculo" << endl;
    cout << "Área: " << circulo.getArea() << endl;
    cout << "Perímetro: " << circulo.getPerimetro() << endl;

    return 0;
}
