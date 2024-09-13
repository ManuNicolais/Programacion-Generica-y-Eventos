#include <iostream>
#include <unordered_map>
#include <functional>

using namespace std;

// Callbacks
void gameMode() {
    cout << "Game Mode activado" << endl;
}

void editMode() {
    cout << "Edit Mode activado" << endl;
}


// Función de error
void showError(const string& mode) {
    cout << "Ya estás en el modo " << mode << "." << endl;
}

// Clase despachador de eventos
class EventDispatcher {
public:
    unordered_map<char, function<void()>> eventHandlers;  // Mapa de eventos y callbacks
    string currentMode = "";  // Variable para almacenar el modo actual

    void addEventHandler(char eventKey, function<void()> handler) {
        eventHandlers[eventKey] = handler;
    }

    // Bucle de eventos, esperando la entrada del usuario
    void runEventLoop() {
        char key;
        bool running = true;

        while (running) {
            
            cout << "Seleccione modo (g: Game Mode, e: Edit Mode, q: Salir): ";
            cin >> key;

            if (key == 'q') {
                running = false;  // Salir del bucle si se ingresa 'q'
            } else if (eventHandlers.find(key) != eventHandlers.end()) {
                // Determina el modo seleccionado según la tecla ingresada
                string selectedMode = (key == 'g') ? "Game Mode" : "Edit Mode";

                // Verifica si el modo seleccionado ya está activo
                if (currentMode == selectedMode) {
                    showError(currentMode);  // Error!! si el modo ya está activo
                } else {
                    // Actualiza el modo actual y llama al callback
                    currentMode = selectedMode;
                    eventHandlers[key]();
                }
            } else {
                cout << "Evento no reconocido." << endl;  // Tecla no reconocida
            }
        }

        cout << "Saliendo del bucle de eventos." << endl;
    }
};

int main() {
    EventDispatcher dispatcher;

    dispatcher.addEventHandler('g', gameMode);
    dispatcher.addEventHandler('e', editMode);

    dispatcher.runEventLoop();

    return 0;
}
