using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RawImageUVPicker_Wei : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] 
    private RawImage rawImage;

    [SerializeField] 
    private Camera camera;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (rawImage == null || rawImage.texture == null)
            return;

        RectTransform rt = rawImage.rectTransform;

        // Convert screen point to local point in RawImage space
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            rt, eventData.position, eventData.pressEventCamera, out Vector2 localPoint))
        {
            // Normalize local point to [0,1] UV coordinates
            Rect rect = rt.rect;
            float u = Mathf.InverseLerp(rect.xMin, rect.xMax, localPoint.x);
            float v = Mathf.InverseLerp(rect.yMin, rect.yMax, localPoint.y);

            // Adjust for RawImage UV rect (in case of tiling/offset)
            Rect uvRect = rawImage.uvRect;
            u = uvRect.x + u * uvRect.width;
            v = uvRect.y + v * uvRect.height;

            //Debug.Log($"UV: ({u:F3}, {v:F3})");

            // If you want pixel coordinates in the texture:
            int texX = Mathf.RoundToInt(u * rawImage.texture.width);
            int texY = Mathf.RoundToInt(v * rawImage.texture.height);
            //Debug.Log($"Pixel: ({texX}, {texY})");

            RaycastHit hit;
            Vector3 AdjustedScreenPosition = new Vector3 (Mathf.RoundToInt(u * Screen.width), Mathf.RoundToInt(v * Screen.height), 0.0f);
            Ray ray = camera.ScreenPointToRay(AdjustedScreenPosition);
            //Debug.Log(AdjustedScreenPosition.x);   
            Debug.DrawRay(ray.origin, ray.direction *100.0f, Color.green);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.name);
                
                ToggleHighLightOnObj script = hit.collider.GetComponent<ToggleHighLightOnObj>();
                if(script != null)
                {
                    script.TriggerHighlight();
                }

            }


        }
    }
}