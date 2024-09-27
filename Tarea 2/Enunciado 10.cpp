#include <iostream>
using namespace std;

// Definir un tamaño máximo para el carrito
const int MAX_PRODUCTOS = 100;

// Clase Producto
class Producto {
    private:
        string nombre;
        float precio;
        int cantidad;

    public:
        Producto() {}  // Constructor por defecto

        Producto(string nombre, float precio, int cantidad) {
            this->nombre = nombre;
            this->precio = precio;
            this->cantidad = cantidad;
        }

        string getNombre() {
            return nombre;
        }

        float getPrecio() {
            return precio;
        }

        int getCantidad() {
            return cantidad;
        }

        float calcularCosto() {
            return precio * cantidad;
        }
};

// Clase CarritoDeCompras
class CarritoDeCompras {
    private:
        Producto productos[MAX_PRODUCTOS];
        int numProductos;

    public:
        CarritoDeCompras() : numProductos(0) {}

        void agregarProducto(const Producto &producto) {
            if (numProductos < MAX_PRODUCTOS) {
                productos[numProductos] = producto;
                numProductos++;
            } else {
                cout << "El carrito está lleno, no se pueden agregar más productos." << endl;
            }
        }

        float calcularTotal() {
            float total = 0.0;
            for (int i = 0; i < numProductos; i++) {
                total += productos[i].calcularCosto();
            }
            return total;
        }

        float aplicarDescuento(float porcentajeDescuento) {
            float total = calcularTotal();
            float descuento = total * (porcentajeDescuento / 100);
            return total - descuento;
        }

        void mostrarProductos() {
            cout << "Productos en el carrito:" << endl;
            for (int i = 0; i < numProductos; i++) {
                cout << productos[i].getNombre() << " - Cantidad: " << productos[i].getCantidad()
                     << " - Precio Unitario: $" << productos[i].getPrecio() << endl;
            }
        }
};

int main() {
    // Crear un carrito de compras
    CarritoDeCompras carrito;

    // Crear productos
    Producto producto1("Laptop", 1000.0, 1);
    Producto producto2("Mouse", 20.0, 2);
    Producto producto3("Teclado", 50.0, 1);

    // Agregar productos al carrito
    carrito.agregarProducto(producto1);
    carrito.agregarProducto(producto2);
    carrito.agregarProducto(producto3);

    // Mostrar productos en el carrito
    carrito.mostrarProductos();

    // Calcular total
    cout << "Total: $" << carrito.calcularTotal() << endl;

    // Aplicar descuento del 10%
    cout << "Total con descuento del 10%: $" << carrito.aplicarDescuento(10) << endl;

    return 0;
}
