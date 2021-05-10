using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaImagens : MonoBehaviour
{
    //objetos bolinhas
    public GameObject bcabeca;
    public GameObject bbraco1;
    public GameObject bperna1;
    public GameObject bcauda;
    public GameObject bcorpoCabeca;
    public GameObject bcorpoPerna1;
    public GameObject bcorpoBraco1;
    public GameObject bcorpoCauda;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            bemEncaixado(bcabeca,bcorpoCabeca);
            bemEncaixado(bbraco1,bcorpoBraco1);
            bemEncaixado(bperna1,bcorpoPerna1);
            bemEncaixado(bcauda,bcorpoCauda);

            /*bcabeca.GetComponent<Renderer>().material.color = Color.green;
            bbraco1.GetComponent<Renderer>().material.color = Color.green;
            bperna1.GetComponent<Renderer>().material.color = Color.green;
            bcauda.GetComponent<Renderer>().material.color = Color.green;
            bcorpoCabeca.GetComponent<Renderer>().material.color = Color.green;
            bcorpoPerna1.GetComponent<Renderer>().material.color = Color.green;
            bcorpoBraco1.GetComponent<Renderer>().material.color = Color.green;
            bcorpoCauda.GetComponent<Renderer>().material.color = Color.green;*/
        }
    }

    public void bemEncaixado(GameObject objeto, GameObject corpo){
        Vector3 posObjeto = objeto.transform.position;
        Vector3 poscorpo = corpo.transform.position;
        
        double distx = posObjeto.x - poscorpo.x;
        double disty = posObjeto.y - poscorpo.y;

        if(distx < 0) distx = distx * (-1);
        if(disty < 0) disty = disty * (-1);
        
        Debug.Log(distx);
        if((distx <= 10)&&(disty <= 10)){
            objeto.GetComponent<Renderer>().material.color = Color.green;
            corpo.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
