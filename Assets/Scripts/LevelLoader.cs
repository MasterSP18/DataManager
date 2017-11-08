using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Xml;
using System.Xml.Serialization; 
using System.IO;
using System.Xml.Linq;
namespace Data {

    public class LevelLoader : MonoBehaviour {

        XDocument xmlDoc; //create Xdocument. Will be used later to read XML file 
        IEnumerable<XElement> items; //Create an Ienumerable list. Will be used to store XML Items. 

        List<Recurso> materiales = new List<Recurso>(); //Initialize List of XMLData objects.
        [SerializeField]
        int nivel = 1;
        int iteration;
        int compradoresMin = 0;
        int compradoresMax = 0;
        int impostoresMin = 0;
        int impostoresMax = 0;
        int metaDinero = 0;
        int limiteTiempo = 0;
        bool finishedLoading = false;
        Recurso recurso = new Recurso("al01", "aluminio", true, 5);
        Recurso recurso1 = new Recurso("gold01", "oro", true, 50);
        
        string path = "Assets/Resources/XML Files/recursos.xml";

        

        void Start() {
            iteration = nivel;
            DontDestroyOnLoad(gameObject); 
            LoadXML();
            materiales.Add(recurso);
            materiales.Add(recurso1);
			XMLSerializer.serializer(recurso,path);
            
        }

        void Update() {

            if (finishedLoading) {

                Application.LoadLevel("TestScene"); //Only happens if coroutine is finished 
                finishedLoading = false;

            }

        }

        public void LoadXML() {


        }

        //this is our coroutine that will actually read and assign the XML data to our List IEnumerator 

        IEnumerator AssignData() {
            foreach (var item in items) {
            /**
                if (item.Attribute("nivel").Value== iteration.ToString()) {
                    Debug.Log("paso por aqui");
                    nivel = int.Parse(item.Attribute("nivel").Value);
                    compradoresMin = int.Parse(item.Parent.Attribute("compradoresMin").Value);
                    compradoresMax = int.Parse(item.Parent.Attribute("compradoresMax").Value);
                    impostoresMin = int.Parse(item.Parent.Attribute("impostoresMin").Value);
                    impostoresMax = int.Parse(item.Parent.Attribute("impostoresMax").Value);
                    metaDinero = int.Parse(item.Parent.Attribute("metaDinero").Value);
                    limiteTiempo = int.Parse(item.Parent.Attribute("limiteTiempo").Value);
                    niveles.Add(new Nivel(nivel, compradoresMin, compradoresMax, impostoresMin, impostoresMax,
                        metaDinero, limiteTiempo));
                    // Debug.Log(niveles[iteration-1]);
                    iteration++;
                }
                **/
            }

            finishedLoading = true; //tell the program that we’ve finished loading data. 
            yield return null;
        }

    }
}
 


