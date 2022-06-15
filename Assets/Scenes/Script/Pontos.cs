using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    public static Pontos pontos;
    private int moedasAtual = 0;
    public Text moedasText;

    
    private void OnCollisionEnter2D(Collision2D other) {

       /* if (pontos == null)
        {
          pontos = this;  
        }
        else if (pontos != this){
            Destroy(gameObject);
        }*/
        Debug.Log("TESTEEEEEE");
    }
    

    
   

    public void SetMoedas (){
        moedasAtual++;
        moedasText.text = moedasAtual.ToString();
    }

    public int GetMoedas (){
        return moedasAtual;
    }

    
}
