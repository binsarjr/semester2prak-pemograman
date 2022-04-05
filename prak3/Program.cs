using System;

namespace TheSuperComputer {
	class Monitor {
		private String resolution;
		private Boolean supportHdmi;
		private double size;
		
		public Monitor(String resolution, Boolean supportHdmi, double size) {
			this.resolution = resolution;
			this.supportHdmi=supportHdmi;
			this.size=size;
		}
		
		private String getResolution() {
			return this.resolution;
		}
		private Boolean isSupportHdmi() {
			return this.supportHdmi;
		}
		private double getSize() {
			return this.size;
		}
		
		public override string ToString() {
			return $"Monitor resolution {this.resolution}; Monitor support hdmi : {this.supportHdmi}; Monitor dimensi : {this.size} inch";
		}
	}
	
	class Printer {
		private String brand;
		private String series;
		private int ppm;
		public Printer(String brand, String series, int ppm) {
			this.brand=brand;
			this.series=series;
			this.ppm=ppm;
		}
		
		public String getBrand() {
			return this.brand;
		}
		
		public String getSeries() {
			return this.series;
		}
		
		public int getPpm() {
			return this.ppm;
		}
		
		public override String ToString() {
			return $"Printer brand : {this.brand} ; Printer Series : {this.series} ; Printer paper per minutes (ppm) : {this.ppm}";
		}
	}
	
	class Processor {
		//processor : series, core, cache
		private String series;
		private int core;
		private int cache;
		
		public void setSeries(String series){
			this.series = series;
		}
		public String getSeries(){
			return this.series;
		}
		public void setCore(int core){
			this.core = core;
		}
		public int getCore(){
			return this.core;
		}
		public void setCache(int cache){
			this.cache = cache;
		}
		public int getCache(){
			return this.cache;
		}
		public override string ToString()
		{
			return $"Processor series:{this.series}; Processor core: {this.core} ; Processor cache:{this.cache}";
		}
	}
	
	class Ram {
		//type, speed, memorySize
		private String type;
		private int speed;
		private int memorySize;
		public Ram(String type,int speed,int memorySize){
			this.type = type;
			this.speed = speed;
			this.memorySize = memorySize;
		}
		public String getType(){
			return this.type;
		}
		public int getSpeed(){
			return this.speed;
		}
		public int getMemorySize(){
			return this.memorySize;
		}
		public override string ToString()
		{
			return $"Ram type : {this.type} ; Ram speed : {this.speed} ; Ram size :{this.memorySize}";
		}
	}
	
	class Vga {
		//brand,graphics clock, memory clock
		private String brand;
		private int graphicsClock;//Mhz
		private int memoryClock;//Mhz
		public Vga(String brand,int graphicsClock, int memoryClock ){
			this.brand = brand;
			this.graphicsClock = graphicsClock;
			this.memoryClock = memoryClock;
		}
		public String getBrand(){
			return this.brand;
		}
		public int getGraphicsClock(){
			return this.graphicsClock;
		}
		public int getMemoryClock(){
			return this.memoryClock;
		}
		public override string ToString()
		{
		return $"Vga brand : {this.brand} ; Vga clock graphics : {this.graphicsClock} ; Vga clock memory : {this.memoryClock} ";
		}
	}
	
	class Computer {
		private Monitor monitor;
		private Printer printer;
		private Processor processor;
		private Ram ram;
		private Vga vga;

		private Computer(Builder builder){
			this.monitor = builder.monitor;
			this.processor = builder.processor;
			this.printer = builder.printer;
			this.ram = builder.ram;
			this.vga = builder.vga;
		}
		public override string ToString()
		{
			return $"Monitor spec :{this.monitor} \n"+
			$"Processor spec : {this.processor} \n"+
			$"Printer spec : {this.printer} \n"+
			$"Vga spec : {this.vga} \n"+
			$"Ram spec : {this.ram}";
		}
		public class Builder{
			public Monitor monitor;
			public Printer printer;
			public Processor processor;
			public Ram ram;
			public Vga vga;
			public Builder(Ram ram,Vga vga, Processor processor){
				this.ram = ram;
				this.vga = vga;
				this.processor = processor;
			}
			public Builder withMonitor(Monitor monitor){
				this.monitor = monitor;
				return this;
			}
			public Builder withPrinter(Printer printer){
				this.printer = printer;
				return this;
			}
			public Computer build(){
				return new Computer(this);
			}
		}
	}
	
	
	
	class Program {
		static void Main(string[] args) {
			Monitor lgMonitor = new Monitor("1200x600",true,32);
			Printer hpPrinter = new Printer("HP","MP102",50);
			Vga nvdiaVga = new Vga("Nvidia",2054,2054);
			Ram samsungRam = new Ram("DDR4",5000,8000);
			Processor intelProcessor = new Processor();
			intelProcessor.setCache(254);
			intelProcessor.setCore(8);
			intelProcessor.setSeries("CORE i7 8th Gen");
			Computer computer = new
			Computer.Builder(samsungRam,nvdiaVga,intelProcessor)//parameter wajib
			.withMonitor(lgMonitor)//parameter opsional
			.withPrinter(hpPrinter)//parameter opsional
			.build();
			Console.WriteLine(computer.ToString());
		}
	}
}


