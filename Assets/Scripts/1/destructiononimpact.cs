using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class destructiononimpact : MonoBehaviour
{
   public Tilemap Tilemap;
   [SerializeField] private AudioSource popSound;
   private void Start()
   {
      Tilemap tilemap = GetComponent<Tilemap>();
   }
   private void OnCollisionEnter2D(Collision2D collision)
   {
   if (collision.gameObject.tag == "tiles")
   {
      popSound.Play();
      Vector3 hitPosition = Vector3.zero;
      foreach (ContactPoint2D hit in collision.contacts)
      {
      Debug.Log(hit.point);
      hitPosition.x = hit.point.x - 0.1f;
      hitPosition.y = hit.point.y - 0.1f ;
      Tilemap.SetTile(Tilemap.WorldToCell(hitPosition), null);
      }
   }
      Destroy(gameObject);
   }
}
