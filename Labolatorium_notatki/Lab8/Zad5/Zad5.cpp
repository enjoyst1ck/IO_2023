#include<iostream>

class A {

};

class B : virtual public A {

};
class C : virtual public A {

};
class D : virtual public B, C {

};

int main()
{
	/*
	Wirtualne dziedziczenie stosujemy aby:
	-utworzyć hierarachie klas, 
	-uniknąć powtarzania kodu, 
	-rozszerzyć funkcjonalność klas, 
	-zastosować polimorfizm, 
	-utworzenie abstrakcji.
	Stosowanie wirtualnego dziedziczenia przynosi wiele korzyści takich jak: ponowne wuykorzstanie kodu, łatwiejsze zarządzanie, rozszerzalność oraz elastyczność.
	*/
	return 0;
}