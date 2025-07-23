using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public interface LinkedListADT
    {
        //Checks if the list is empty.
	    //return True if it is empty.
        bool IsEmpty();

        //Clears the list.
        void Clear();

        //Adds to the end of the list.
        //Object data to append.
        void Append(Object data);

        //Prepends (adds to beginning) data to the list.
        //parameter Object Data to store inside element.
        void Prepend(Object data);

        //Adds a new element at a specific position.
        //parameter data Data that element is to contain.
        //parameter index Index to add new element at.
        //throws exception IndexOutOfRangeException Thrown if index is negative or past the size of the list.
        void Insert(Object data, int index);

        //Replaces the data  at index.
        //parameter data Data to replace.
        //parameter index Index of element to replace.
        //throws IndexOutOfRangeException Thrown if index is negative or larger than size - 1 of list.
        void Replace(Object data, int index);

        //Gets the number of elements in the list.
        //return Size of list (0 meaning empty)
        int Size();

        //Removes element at index from list, reducing the size.
        //parameter index Index of element to remove.
        //throws exception IndexOutOfBoundsException Thrown if index is negative or past the size - 1.
        void Delete(int index);

        //Gets the data at the specified index.
        //parameter index Index of element to get.
        //return Data in element or null if it was not found.
        //throws exception IndexOutOfRangeException Thrown if index is negative or larger than size - 1 of the list.
        Object Retrieve(int index);

        //Gets the first index of element containing data.
        //parameter data Data object to find the first index of.
        //return First of index of element with matching data or -1 if not found.
        int IndexOf(Object data);

        //Go through elements and check if we have one with data.
        //parameter data Data object to search for.
        //return True if element exists with value.
        bool Contains(Object data);
    }
}
