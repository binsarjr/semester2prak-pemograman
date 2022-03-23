class Thermometer
{
    public ISuhu suhu;
    private string hasil;

    public   void celciusToFahrenheit(int celcius)
    {
        this.suhu = new Celcius(celcius);
        this.hasil = this.suhu.toFahrenheit();
    }

    public   void fahrenheitToCelcius(int fahrenheit)
    {
        this.suhu = new Fahrenheit(fahrenheit);
        this.hasil = this.suhu.toCelcius();
    }

    public    void celciusToKelvin(int celcius)
    {
        this.suhu = new Celcius(celcius);
        this.hasil = this.suhu.toKelvin();
    }

    public   string result()
    {
        return this.hasil;
    }
}
