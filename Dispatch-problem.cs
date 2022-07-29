using System;
					
public class A{

    public virtual void M(){
        Console.WriteLine("A.M");
    }

}

public class B:A{

    public override void M()
    {
        Console.WriteLine("B.M");
    }

}

public class C{

public  void N(A obj){
    Console.WriteLine("C.A.N");
    obj.M();
}
public void N(B obj){
    Console.WriteLine("C.B.N");
    obj.M();
}

}
public class Program
{
	public static void Main()
	{
		A obj=new B();
		C cObj=new C();
		cObj.N(obj);
	}
}
