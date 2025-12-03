using UnityEngine;

public class VolumePulsation : MonoBehaviour
{
    [Header("Настройки пульсации")]
    public float pulseSpeed = 1f;        // Скорость пульсации
    public float minVolume = 0.1f;       // Минимальная громкость
    public float maxVolume = 0.5f;         // Максимальная громкость
    public bool startOnPlay = true;      // Запуск при старте
    
    private AudioSource audioSource;
    private float timer = 0f;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        if (audioSource == null)
        {
            Debug.LogError("Нет AudioSource на объекте!");
            return;
        }
        
        if (startOnPlay && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
    
    void Update()
    {
        if (audioSource == null || !audioSource.isPlaying) return;
        
        // Увеличиваем таймер
        timer += Time.deltaTime * pulseSpeed;
        
        // Используем синус для плавного изменения громкости
        // Синус дает значения от -1 до 1, преобразуем в 0-1
        float sinValue = Mathf.Sin(timer);
        float normalizedSin = (sinValue + 1f) / 2f; // От 0 до 1
        
        // Применяем к диапазону громкости
        float currentVolume = Mathf.Lerp(minVolume, maxVolume, normalizedSin);
        audioSource.volume = currentVolume;
        
        // Для отладки
        //Debug.Log($"Громкость: {currentVolume:F2}, Таймер: {timer:F2}");
    }
    
    // Методы для управления
    public void StartPulsation()
    {
        if (audioSource != null)
        {
            audioSource.Play();
            timer = 0f;
        }
    }
    
    public void StopPulsation()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
    
    public void SetPulseSpeed(float speed)
    {
        pulseSpeed = Mathf.Max(0.1f, speed);
    }
    
    public void SetVolumeRange(float min, float max)
    {
        minVolume = Mathf.Clamp01(min);
        maxVolume = Mathf.Clamp01(max);
    }
}