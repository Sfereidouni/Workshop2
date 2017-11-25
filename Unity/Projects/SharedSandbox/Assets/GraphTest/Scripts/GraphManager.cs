using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SpatialSlur.SlurCore;
using SpatialSlur.SlurMesh;

/*
 * Notes
 */

namespace GraphIntro
{
    /// <summary>
    /// 
    /// </summary>
    public class GraphManager : MonoBehaviour
    {
        private Mesh _displayMesh;

        private HeGraph3d _graph;

        private Vector3[] _positions;
        private Vector2[] _texCoords0;
        


        /// <summary>
        /// 
        /// </summary>
        void Start()
        {
            _displayMesh = GetComponent<MeshFilter>().sharedMesh;
            _displayMesh.MarkDynamic();

            _graph = CreateGrid(10, 10);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countX"></param>
        /// <param name="countY"></param>
        /// <returns></returns>
        HeGraph3d CreateGrid(int countX, int countY)
        {
            var graph = new HeGraph3d();

            // add vertices
            for (int i = 0; i < countY; i++)
            {
                for (int j = 0; j < countX; j++)
                {
                    var v = graph.AddVertex();
                    v.Position = new Vec3d(i, j, 0);
                    // v.Normal = blah;
                    // v.Texture = blah;
                }
            }

            // add edges
            int index = 0;
            for (int i = 0; i < countY; i++)
            {
                for (int j = 0; j < countX; j++)
                {
                    if (j > 0)
                        graph.AddEdge(index, index - 1);

                    if (i > 0)
                        graph.AddEdge(index, index - countX);

                    index++;
                }
            }

            return graph;
        }
    }
}