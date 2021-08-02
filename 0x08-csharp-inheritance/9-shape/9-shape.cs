using System;

/// <summary>
/// Base class for shapes. 
/// </summary>
class Shape
{
    /// <summary>
    /// Not Implemented yet
    /// </summary>
    /// <returns>An integer</returns>
    public virtual int Area(){
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>
/// Rectangle class derived from shape class.
/// </summary>
class Rectangle:Shape{
    private int width;
    private int height;
    /// <summary>
    /// get: retrieve width
    /// set: if value is negative, throw an ArgumentException with the message Width
    /// must be greater than or equal to 0. Otherwise, set width to the value.
    /// </summary>
    /// <value>width type(int)</value>
    public int Width{
        get{
            return width;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    /// <summary>
    /// get: retrieve height
    /// set: if value is negative, throw an ArgumentException with the message Height
    /// must be greater than or equal to 0. Otherwise, set Height to the value.
    /// </summary>
    /// <value>height type(int)</value>
    public int Height{
        get{
            return height;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
    /// <summary>
    /// This will override the Area() method defined in the Shape base class.
    /// </summary>
    /// <returns>Returns the area of the rectangle</returns>
    public override int Area(){
        return this.height * this.width;
    }
    /// <summary>
    /// This will provide a better representation for the Rectangle. 
    /// [Rectangle] width / height.
    /// </summary>
    public override string ToString(){
        return String.Format("[Rectangle] {0} / {1}", this.width, this.height);
    }
}
/// <summary>
/// Square class derived from Rectangle
/// </summary>
class Square:Rectangle{
    private int size;
    /// <summary>
    /// Getter and setter for size value
    /// </summary>
    /// <value>Size type(int)</value>
    public int Size{
        get{
            return this.size;
        }
        set{
            if (value < 0){
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            base.Height = value;
            base.Width = value;
            this.size = value;
        }
    }
    /// <summary>
    /// [Square] size / size
    /// </summary>
    public override string ToString(){
        return String.Format("[Square] {0} / {0}", this.size);
    }
}