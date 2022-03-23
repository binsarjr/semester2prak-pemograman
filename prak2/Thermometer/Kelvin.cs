
class Kelvin: ISuhu
{
    public    double suhu;
    public Kelvin(double suhu)
    {
        this.suhu = suhu;
    }
    public    string toFahrenheit()
    {

        return "";//nanti dulu
    }
    public   string toCelcius()
    {
        return ""; //nanti dl
    }
    public   string toKelvin()
    {
        return this.suhu + SatuanSuhu.Kelvin; // nanti dulu
    }
}
