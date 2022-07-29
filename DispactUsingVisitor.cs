using System;
using System.Collections.Generic;

//Object Structure
public class ComplexObject{

	List<A> _structure=new List<A>();
	public void Operation(C visitor){
		foreach(A item in _structure){
		
			item.Accept(visitor);
		}
	}
	
	public void AddStructureItem(A item){
		_structure.Add(item);
	}
}
public class A{

    public virtual void M(){
        Console.WriteLine("A.M");
    }
	public virtual void Accept(C visitor){
		
		visitor.O(this);
	}

}

public class B:A{

    public override void M()
    {
        Console.WriteLine("B.M");
    }
	public override void Accept(C visitor){
		
		visitor.O(this);
	}

}

//Visitor Class
public class C{

	//operation
public  void O(A obj){
    Console.WriteLine("C.A.N");
    obj.M();
}
	//operation
public void O(B obj){
    Console.WriteLine("C.B.N");
    obj.M();
}

}
public class Program
{
	public static void Main()
	{
		A obj=new A();
		A obj_b=new B();
		
		ComplexObject tree=new ComplexObject();
	    tree.AddStructureItem(obj);
		tree.AddStructureItem(obj_b);
		
		C cObj=new C();
	    tree.Operation(cObj);
	}
}
