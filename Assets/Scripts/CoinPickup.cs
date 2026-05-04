using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public GameObject effectPrefab;
    public AudioClip pickupSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 이펙트
            if (effectPrefab != null)
            {
                Instantiate(effectPrefab, transform.position, Quaternion.identity);
            }

            // 🔊 사운드
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }

            // 점수
            GameManager.instance.AddScore(1);

            // 삭제
            Destroy(gameObject);
        }
    }
}