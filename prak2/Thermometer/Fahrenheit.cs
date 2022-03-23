class Fahrenheit: ISuhu
{
    public    int suhu;
    public  Fahrenheit(int suhu)
    {
        this.suhu = suhu;
    }
    public string toFahrenheit()
    {
        return this.suhu + SatuanSuhu.Fahrenheit;
    }
    public  string toCelcius()
    {
        return "(" + this.suhu + SatuanSuhu.Fahrenheit + " - 32) x 5/9 = " + ((this.suhu - 32) * 5 / 9) .ToString() + SatuanSuhu.Celcius;
    }
    public   string toKelvin()
    {
        return ""; // nanti dulu
    }

}
