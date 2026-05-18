using UnityEngine;

public class move : MonoBehaviour
{
    // Borunun sola doğru gitme hızı
    public float speed = 2f;

    void Update()
    {
        // Nesneyi her karede sola doğru hareket ettirir
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Eğer boru ekranın çok soluna çıkarsa otomatik yok et (opsiyonel)
        if (transform.position.x < -2f)
        {
            Destroy(gameObject);
        }
    }
}