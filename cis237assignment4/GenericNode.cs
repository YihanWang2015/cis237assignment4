/*
Author: Yihan Wang
Date:   11-10-2015
Description:    Class that implements a generic node to be used in a bucket sort
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericNode<T>
    {
        public GenericNode<T> Next
        {
            get;
            set;
        }

        public T Data
        {
            get;
            set;
        }
    }
}
