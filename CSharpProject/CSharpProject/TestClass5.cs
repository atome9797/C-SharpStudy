using System;
using System.Collections.Generic;
using System.Text;

interface IFlyable { void Fly(); }


struct Foo : IFlyable
{
    public void Fly() { }
}

int i = 10; // Value Type
object obj = i; // Reference Type으로 받음 => Boxing
int a = (int)obj; //Unboxing, 10

Foo f = new Foo();//Value Type 
IFlyable f2 = f;//Reference Type => Boxing


