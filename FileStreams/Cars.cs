public class Cars
{
    const string CARS_FILE = "cars.csv";
    public string CarsFile { get { return CARS_FILE; }}

    private string[] cars = 
    {
        "make, model, year, mileage",
        "Chevrolet, S10, 1996, 195000",
        "Chrysler, Pacifica, 2023, 20000",
        "Kia, Soul, 2024, 100",
        "Chevrolet, Camaro, 1968, 100000"
    };

    public void WriteStream()
    {
        StreamWriter file = new StreamWriter(CARS_FILE);

        foreach(string car in cars)
        {
            file.WriteLine(car);
        }

        file.Close();
    }

    public bool ReadStream()
    {
        //  Check that the file exists
        if(!File.Exists(CARS_FILE))
            return false;

        StreamReader reader = new StreamReader(CARS_FILE);

        //  Re-initialize the array
        cars = new string[100];

        int i = 0;
        while(!reader.EndOfStream)
        {
            cars[i++] = reader.ReadLine();
        }

        reader.Close();

        return true;
    }

    public string GetCar(int row)
    {
        string car = string.Empty;

        try
        {
            car = cars[row];

            if(!string.IsNullOrEmpty(car))
            {
                string[] carDetail = car.Split(",");

                car = $"The make of the car is {carDetail[0]}, and the model is {carDetail[1]} from the year {carDetail[2]}. It has {carDetail[3]} miles on it";
            }
            else
                car = "Invalid Car";
        }
        catch
        {
            car = $"Invalid Row";
        }

        return car;
    }

    public override string ToString()
    {
        string data = string.Empty;

        int i = 1;
        foreach(string car in cars)
            if(!string.IsNullOrEmpty(car))
                data += $"{i++} - {car}\n";

        return data;
    }
}