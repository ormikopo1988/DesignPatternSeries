using System.Collections.Generic;

namespace Composite.Problem
{
    /// <summary>
    /// We need to build a hierarchy of objects. 
    /// The objects of the Group class must be able to contain either other Group objects or Shape objects
    /// </summary>
    public class Group
    {
        private List<object> objects = new List<object>();

        public void Add(object newObject)
        {
            objects.Add(newObject);
        }

        public void Render()
        {
            foreach (var obj in objects)
            {
                if (obj is Shape)
                {
                    ((Shape)obj).Render();
                }
                else if (obj is Group)
                {
                    ((Group)obj).Render();
                }
            }
        }
    }
}
