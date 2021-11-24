using System;

interface ICamera
{
    void Take();
}

class MP3
{
    public virtual void Play()
    {

    }
}

class SmartPhone : MP3, ICamera
{
    public override void Play() // override O
    {

    }

    public void Take() // override X
    {
        
    }
    // public virtual void Take() { } // virtual 메소드도 가능하다.
    
}

class Program
{
    static void Main()
    {

    }
}