using System.Collections;
using System.Collections.Generic;
using UnityEngine; //Uso de NameSpace -> Importando una librería. -> Contienen clases/código.

public class Test : MonoBehaviour
{
    /* 
        Se carga antes de que cargué una escena.
        Se ejecuta 1 sola vez.
        Obtener componentes.
    */
    private void Awake() {
        print("Awake"); // -> Debug.Log("Mensaje");
    }

    /*
        Se carga al cargar una escena.
        Se ejecuta 1 sola vez.
        Inicializar variables.
    */
    private void Start() {
        print("Start");
    }

    /*
        Se ejecuta 1 vez por frame.
        Si el juego corre a 60fps -> Este método se ejecuta 60 veces en 1 segundo.
        Trabaja la lógica de juego y estado de algún gameobject. 
    */
    private void Update() {
        //print("Update");
    }

    /*
        Se ejecuta cada 0,002 segundos.
        Está determinado por el Physics de Unity.
        Trabaja todo lo que es gestión de colisiones físicas, acelaramiento, velocidad, etc.
    */
    private void FixedUpdate() {
        //print("Fixed Update");
    }
}
