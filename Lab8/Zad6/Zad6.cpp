#include <iostream>

class A {
public:
    void funkcjaA() {
        std::cout << "Jestem z klasy A." << std::endl;
    }
};

class B : public A {
public:
    void funkcjaB() {
        std::cout << "Jestem z klasy B." << std::endl;
    }
};

int main() {
    /*
    Aby móc wywołać obie metody, należy utworzyć obiekt klasy podrzędnej, 
    dzięki czemu możemy wywołać metody z tejże klasy oraz z klasy, która jest dla niej nadrzędna.
    */

    B obj;
    obj.funkcjaA();
    obj.funkcjaB();

    return 0;
}