#include <iostream>

template<typename T>
class A {

private: T t;
         
public: 
    A(T value) : t(value) {}

    void pokaz_t() {
        std::cout << "Wartosc parametru t: " << t << std::endl;
    }
};

int main() {
    A<int> obj1(10);
    obj1.pokaz_t();

    A<char> obj2('A');
    obj2.pokaz_t();

    A<double> obj3(3.14);
    obj3.pokaz_t();

    return 0;
}