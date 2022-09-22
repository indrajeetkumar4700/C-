using System;
 
public class PropertyHolder
{
    private int someProperty = 0;
 
    public PropertyHolder() { }
 
    public PropertyHolder(int iVal)
    {
        SomeProperty = iVal;
    }

    public int SomeProperty
    {
        get
       {
            return someProperty;
        }
        set
       {
            someProperty = value;
        }
    }
 
    public void setPropValue(int iVal)
    {
        SomeProperty = iVal;
    }
}