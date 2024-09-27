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

        CuentaBancaria(){
            saldo = 0;
            numeroCuenta = "";
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

        CuentaCorriente(){
            setSaldo(0);
            setNumeroCuenta("");
        }

        void cobrarComisiones(int comision){
            float saldo = getSaldo();
            setSaldo(saldo - comision);//Se cobra una comisión de 10 como ejemplo
        }
};

class CuentaAhorro : public CuentaBancaria { //clase hijo de CuentaBancaria
    public:
        CuentaAhorro(float saldo, string numeroCuenta) : CuentaBancaria(saldo, numeroCuenta) {}

        void calcularIntereses(int interes){
            float saldo = getSaldo();
            setSaldo(saldo + (saldo * interes));//Se calcula un interés del 5% como ejemplo
        }
};