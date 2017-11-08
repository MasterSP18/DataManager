using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data {
    [Serializable]
    public class Recurso {

        public string codigo;
        public string nombre;
        public bool isBase;
        public int valorBase;


        // Create a constructor that will accept multiple arguments that can be assigned to our variables. 
        public Recurso(string codigo, string nombre, bool isBase, int valorBase) {
            this.codigo = codigo;
            this.nombre = nombre;
            this.isBase = isBase;
            this.valorBase = valorBase;
        }

        public Recurso() {

        }

    }
}
