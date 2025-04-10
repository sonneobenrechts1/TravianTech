using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        private GameModel _gameModel;

        public TextMeshProUGUI ScoreMesh;
        public TextMeshProUGUI HighScoreMesh;
        
        public GameObject ObstaclePrefab;
        public Transform ObstaclesParent;

        void Awake()
        {
            _gameModel = new GameModel();

            CreateRandomLevel();
        }

        void Update()
        {
            _gameModel.IncreaseScore();

            ScoreMesh.text = _gameModel.Score.ToString();
            HighScoreMesh.text = _gameModel.HighScore.ToString();
        }

        private void CreateRandomLevel()
        {
            for (int i = 0; i < 100; i++)
            {
                if (Random.value > 0.8f)
                {
                    var position = new Vector3(i*2, 0f, 0f);
                    Instantiate(ObstaclePrefab, position, Quaternion.identity, ObstaclesParent);
                }

            }
        }
    }
}
