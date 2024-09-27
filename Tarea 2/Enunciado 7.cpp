#include <iostream>
using namespace std;

// Clase Animal
class Animal {
    public:
        void comer() {
            cout << "El animal está comiendo." << endl;
        }

        void dormir() {
            cout << "El animal está durmiendo." << endl;
        }

        bool estaEnfermo() {
            return rand() % 2 == 0;
        }

        bool estaDormido() {
            return rand() % 2 == 0;
        }
};

// Clase Veterinario hereda de Animal
class Veterinario : public Animal {
    public:
        void examinar(Animal &animal) {
            cout << "El veterinario está examinando al animal..." << endl;
            if (animal.estaEnfermo()) {
                cout << "El animal está enfermo." << endl;
            } else {
                cout << "El animal está sano." << endl;
            }
            if (animal.estaDormido()) {
                cout << "El animal esta dormido" << endl;
            } else {
                cout << "El animal esta despierto" << endl;
            }
        }
};

int main() {
    //crear un objeto de la clase Veterinario
    Veterinario veterinario;

    //crear un objeto de la clase Animal
    Animal animal;

    //llamar al método examinar del objeto veterinario
    veterinario.examinar(animal);

    return 0;
}
