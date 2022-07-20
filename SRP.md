``` c++
//C++ Code
bool batteryIsOk(float temperature, float soc, float chargeRate) {
  bool isValid=false;
  
 
}

bool isTemperatureInRange(float temperature){
  if(temperature < 0 || temperature > 45) {
    printOnConsole("Temperature out of range!");
    return false;
  } 
  return true
}

bool isSOCInRange(float soc){
 if(soc < 20 || soc > 80) {
   printOnConsole("Soc out of range!");
    return false;
  } 
  return true
}
bool isChargeRateValid(float chargeRate){
  if(chargeRate > 0.8) {
    printOnConsole("Charge Rate out of range!\n");
    return false;
  }
  return true
}
..not unit testable
void printOnConsole(string message){
 cout <<message<<endl";
}
```

``` C#

//C# Code
public class ConsoleLogger : IMessageLogger{

public void Write(string message){
 Console.WriteLine(message);
}
}

public class FileLogger : IMessageLogger{

public void Write(string message){
 //Open and Write File 
}
}

interface IMessageLogger{
  void Write(string message);
}

public class TemperatureParameterValidator{

   float min,max;
   //tightly coupled , violation of DIP
 //  ConsoleLogger _logger=new ConsoleLogger(); //uses,has-a , dependency
 
 //Dependency
   IMessageLogger _logger; //injection
   
   //Constructor Injection
   public TemperatureParameterValidator(IMessageLogger logger){
      this._logger=logger;
   }
   
   public bool Validate(float temperature){
   
     if(temperature < min || temperature > max) {
            this._logger.Write("Temperature is out of range!");
            return false;
   }
   return true;

}
public class Checker
{
    public static bool batteryIsOk(float temperature, float soc, float chargeRate) {
        if(temperature < 0 || temperature > 45) {
            Console.WriteLine("Temperature is out of range!");
            return false;
        } else if(soc < 20 || soc > 80) {
            Console.WriteLine("State of Charge is out of range!");
            return false;
        } else if(chargeRate > 0.8) {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
        }
        return true;
    }
   private static  bool isSOCInRange(float soc){
            if(soc < 20 || soc > 80) {
            printOnConsole("Soc out of range!");
            return false;
      } 
    return true
}

```

``` Java
//Java

public class Main {
    static boolean batteryIsOk(float temperature, float soc, float chargeRate) {
        if(temperature < 0 || temperature > 45) {
            System.out.println("Temperature is out of range!");
            return false;
        } else if(soc < 20 || soc > 80) {
            System.out.println("State of Charge is out of range!");
            return false;
        } else if(chargeRate > 0.8) {
            System.out.println("Charge Rate is out of range!");
            return false;
        }
        return true;
    }
```

``` Python
//Python
def battery_is_ok(temperature, soc, charge_rate):
  if temperature < 0 or temperature > 45:
    print('Temperature is out of range!')
    return False
  elif soc < 20 or soc > 80:
    print('State of Charge is out of range!')
    return False
  elif charge_rate > 0.8:
    print('Charge rate is out of range!')
    return False

  return True

```


