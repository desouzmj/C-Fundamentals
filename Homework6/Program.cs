// File: tv.cs

class Television
{
    private int channel;
    private int volume;
    private bool isOn;

    public bool IsOn
    {
        get
        {
            return isOn;
        }
        set
        {
            isOn = value;
        }

    }
    public int Channel
    {
        get
        {
            return channel;
        }
        set
        {
            channel = value;
        }

    }
    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
            volume = value;
        }
    }
}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        if (!tv.IsOn)
        {
            tv.IsOn = true;
        }

        tv.Channel = 3;

        tv.Volume++;
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;

        tv.IsOn = false;
    }
}