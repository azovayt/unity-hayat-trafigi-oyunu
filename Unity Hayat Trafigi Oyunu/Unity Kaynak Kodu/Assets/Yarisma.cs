using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yarisma : MonoBehaviour
{
    public Text soruismi, cevapa, cevapb, cevapc, cevapd;
    Sorular sr;
    public List<bool> sorulanlar;
    public int cevap;
    void Start()
    {
        sr = GetComponent<Sorular> ();
        for(int i = 0; i < sr.sorular.Count; i++){
            sorulanlar.Add(false);
        }
        SoruEkle();
    }

    
    void Update()
    {
        
    }

    public void SoruEkle(){
        for (int i = 0; i < sorulanlar.Count; i++){
            if (sorulanlar [i] == false){
                int sorusayi = Random.Range(0, sorulanlar.Count);
                if (sorulanlar[sorusayi] == false)
                {
                    sorulanlar[sorusayi] = true;
                    soruismi.text = sr.sorular[sorusayi].soruismi;
                    cevapa.text = sr.sorular[sorusayi].cevapa;
                    cevapb.text = sr.sorular[sorusayi].cevapb;
                    cevapc.text = sr.sorular[sorusayi].cevapc;
                    cevapd.text = sr.sorular[sorusayi].cevapd;
                    cevap = sr.sorular[sorusayi].cevap;
                }
                else
                {
                    SoruEkle();
                }
                break;
            }
            if (i == sorulanlar.Count - i){
                Debug.Log("Oyunu Kazandin");
            }
        }
   
    }
    public void CevapVer(int deger){
        if(deger == cevap){
            SoruEkle();
        }
        else{
            Debug.Log("Yanliş Cevap");
        }
    }
}
