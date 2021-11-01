using System;
using System.Collections.Generic;


public class Room
{
    public string roomName { get; set; }
    public int capacity { get; set; }
    public DateTime availableFrom { get; set; }
    public DateTime availableTo { get; set; }
    public List<Tuple<DateTime, DateTime>> MyProperty { get; set; }





}
