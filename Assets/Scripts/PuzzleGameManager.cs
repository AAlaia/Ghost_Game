using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GhostGame
{
    public class PuzzleGameManager : MonoBehaviour
    {
        [Header("UI Elements")]
        public List<Texture2D> imageTextures;
        public Transform levelSelectPanel;
        public Image levelSelectPrefab;

        private List<Transform> pieces;
        

        // Start is called before the first frame update
        void Start()
        {
            foreach (Texture2D texture in imageTextures)
            {
                Image image = Instantiate(levelSelectPrefab, levelSelectPanel);
                image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

                image.GetComponent<Button>().onClick.AddListener(delegate { StartGame(texture); });
            }
        }

        public void StartGame(Texture2D jigsawTexture)
        {
            levelSelectPanel.gameObject.SetActive(false);

            pieces = new List<Transform>();
        }

        
    }
}