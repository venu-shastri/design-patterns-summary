``` c++
//C++ Code
bool batteryIsOk(float temperature, float soc, float chargeRate) {
  if(temperature < 0 || temperature > 45) {
    cout << "Temperature out of range!\n";
    return false;
  } else if(soc < 20 || soc > 80) {
    cout << "State of Charge out of range!\n";
    return false;
  } else if(chargeRate > 0.8) {
    cout << "Charge Rate out of range!\n";
    return false;
  }
  return true;
}


```

``` C#

//C# Code
class Checker
{
    static bool batteryIsOk(float temperature, float soc, float chargeRate) {
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


