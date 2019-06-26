using System;

public class BarrelRepository
{
    private DataContext dbContext;
    public BarrelRepository()
	{
        dbContext = new DataContext();
	}
}
