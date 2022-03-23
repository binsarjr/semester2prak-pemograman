
class Celcius : ISuhu
{
    public   int suhu;
    public Celcius(int suhu)
    {
        this.suhu = suhu;
    }
    public string toFahrenheit()
    {

        return "(" + this.suhu + SatuanSuhu.Celcius + " x 9/5) + 32 = " + ((this.suhu * 9 / 5) + 32).ToString() + SatuanSuhu.Fahrenheit;
    }
    public string toCelcius()
    {
        return this.suhu + SatuanSuhu.Celcius;
    }
    public string toKelvin()
    {
        return this.suhu + SatuanSuhu.Celcius + " + 273.15 = " + (this.suhu + 273.15) .ToString() + SatuanSuhu.Kelvin;
    }
}

