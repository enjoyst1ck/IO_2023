#include <iostream>

class A
{
    public: int msi_publicLiczba;
    protected: int mi_protLiczba;  
    private: int mi_privLiczba;

public:
    int pokazLiczbe() {
        std::cout << "publicLiczba: " << msi_publicLiczba << std::endl;
        std::cout << "protLiczba: " << mi_protLiczba << std::endl;
        std::cout << "privLiczba: " << mi_privLiczba << std::endl;

        return msi_publicLiczba + mi_protLiczba + mi_privLiczba;    
    }

    void przypiszWartosc(int publicValue, int protectedValue, int privateValue) {
        msi_publicLiczba = publicValue;
        mi_protLiczba = protectedValue;
        mi_privLiczba = privateValue;
    }
};

int main() {
    A obj;

    obj.przypiszWartosc(1, 2, 3);  // Przypisuje nowe wartości atrybutom

    int suma = obj.pokazLiczbe();  // Wyświetla wartości atrybutów i zwraca sumę

    std::cout << "Suma: " << suma << std::endl;

    return 0;
}