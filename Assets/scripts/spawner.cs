using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Unity'den buraya oluşturduğun Boru Prefab'ını sürükleyeceksin
    public GameObject pipePrefab;

    // Kaç saniyede bir yeni boru üretilsin?
    public float spawnTime = 2f;

    // Boruların dikeyde (Y ekseninde) rastgele aşağı-yukarı oynama sınırı
    public float heightRange = 1.5f;

    // Zamanlayıcıyı tutan değişken
    private float timer = 0f;

    void Start()
    {
        // Oyun başlar başlamaz ilk boruyu hemen üretsin
        SpawnPipe();
    }

    void Update()
    {
        // Zamanı akıtıyoruz
        timer += Time.deltaTime;

        // Belirlediğimiz süre (spawnTime) dolduğunda yeni boru üret ve sayacı sıfırla
        if (timer >= spawnTime)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        // Rastgele bir Y koordinatı hesapla (Örn: -2 ile +2 arasında bir yer)
        float randomHeight = Random.Range(-heightRange, heightRange);

        // Borunun doğacağı tam pozisyon (Spawner'ın X ve Z'si, ama Y'si rastgele)
        Vector3 spawnPosition = new Vector3(21, randomHeight, 0f);

        // Boruyu sahnede var et (Oluştur)
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}