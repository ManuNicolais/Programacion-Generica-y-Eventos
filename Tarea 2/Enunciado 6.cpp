//6.	Crear una clase CuentaBancaria con atributos como saldo y número de cuenta y luego crear clases como CuentaCorriente y CuentaAhorro
//que hereden de CuentaBancaria y tengan métodos específicos como cobrar comisiones o calcular intereses.

#include <iostream>
using namespace std;

class CuentaBancaria {
    private:
        float saldo;
        string numeroCuenta;

    public:
        CuentaBancaria(float saldo, string numeroCuenta){
            this->saldo = saldo;
            this->numeroCuenta = numeroCuenta;
        }

        void setSaldo(float saldo){
            this->saldo = saldo;
        }
        float getSaldo(){
            return saldo;
        }
        void setNumeroCuenta(string numeroCuenta){
            this->numeroCuenta = numeroCuenta;
        }
        string getNumeroCuenta(){
            return numeroCuenta;
        }

};

class CuentaCorriente : public CuentaBancaria { //clase hijo de CuentaBancaria
    public:
        CuentaCorriente(float saldo, string numeroCuenta) : CuentaBancaria(saldo, numeroCuenta) {}

        void cobrarComisiones(){
            float saldo = getSaldo();
            setSaldo(saldo - 10);//Se cobra una comisión de 10 como ejemplo
        }
};

class CuentaAhorro : public CuentaBancaria { //clase hijo de CuentaBancaria
    public:
        CuentaAhorro(float saldo, string numeroCuenta) : CuentaBancaria(saldo, numeroCuenta) {}

        void calcularIntereses(){
            float saldo = getSaldo();
            setSaldo(saldo + (saldo * 0.05));//Se calcula un interés del 5% como ejemplo
        }
};

int main() {
    
    CuentaCorriente cuentaCorriente(1000, "1234567890");
    CuentaAhorro cuentaAhorro(5000, "0987654321");

    cout << "Saldo cuenta corriente: " << cuentaCorriente.getSaldo() << endl;
    cuentaCorriente.cobrarComisiones();
    cout << "Saldo cuenta corriente después de cobrar comisiones: " << cuentaCorriente.getSaldo() << endl;

    cout << "Saldo cuenta ahorro: " << cuentaAhorro.getSaldo() << endl;
    cuentaAhorro.calcularIntereses();
    cout << "Saldo cuenta ahorro después de calcular intereses: " << cuentaAhorro.getSaldo() << endl;

    return 0;
}