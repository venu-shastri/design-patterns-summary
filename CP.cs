using System;
using System.Collections.Generic;

//Object Structure
public class Image{

	List<Shape> _structure=new List<Shape>();
	public void Plot(List<ShapePoltter> plotters){
	
	//M*N cartesian product
		foreach(Shape s in _structure){
			foreach(ShapePoltter p in plotters){
				
			}
		}
	}
	
	
}
public abstract class Shape{
	
}

public abstract class Rectangle:Shape{
	
	public string GeHeightAndWidth(){ return "R.H.W";}
}
public abstract class Circle:Shape{
	public string GetRadius(){ return "C.R";}
}
public abstract class Polygon:Shape{
	public string GetSides(){ return "P.S";}
}

public abstract class ShapePoltter{
	
}

public class LaserPrinter : ShapePoltter{
	
}
public class InkJetrinter : ShapePoltter{
	
}

