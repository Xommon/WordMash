using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class BoardManager : MonoBehaviour
{
    public Tile[] tiles;
    public string[] boardData;

    void Update()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            switch (boardData[i])
            {
                case "DL":
                    tiles[i].background.color = Color.grey;
                    tiles[i].faceText.text = "DL";
                    tiles[i].valueText.text = "";
                    break;

                case "TL":
                    tiles[i].background.color = Color.grey;
                    tiles[i].faceText.text = "TL";
                    tiles[i].valueText.text = "";
                    break;

                case "DW":
                    tiles[i].background.color = Color.grey;
                    tiles[i].faceText.text = "DW";
                    tiles[i].valueText.text = "";
                    break;

                case "TW":
                    tiles[i].background.color = Color.grey;
                    tiles[i].faceText.text = "TW";
                    tiles[i].valueText.text = "";
                    break;

                // Letter cases
                case "A":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "A";
                    tiles[i].valueText.text = "1";
                    break;

                case "B":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "B";
                    tiles[i].valueText.text = "3";
                    break;

                case "C":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "C";
                    tiles[i].valueText.text = "3";
                    break;

                case "D":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "D";
                    tiles[i].valueText.text = "2";
                    break;

                case "E":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "E";
                    tiles[i].valueText.text = "1";
                    break;

                case "F":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "F";
                    tiles[i].valueText.text = "4";
                    break;

                case "G":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "G";
                    tiles[i].valueText.text = "2";
                    break;

                case "H":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "H";
                    tiles[i].valueText.text = "4";
                    break;

                case "I":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "I";
                    tiles[i].valueText.text = "1";
                    break;

                case "J":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "J";
                    tiles[i].valueText.text = "8";
                    break;

                case "K":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "K";
                    tiles[i].valueText.text = "5";
                    break;

                case "L":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "L";
                    tiles[i].valueText.text = "1";
                    break;

                case "M":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "M";
                    tiles[i].valueText.text = "3";
                    break;

                case "N":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "N";
                    tiles[i].valueText.text = "1";
                    break;

                case "O":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "O";
                    tiles[i].valueText.text = "1";
                    break;

                case "P":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "P";
                    tiles[i].valueText.text = "3";
                    break;

                case "Q":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "Q";
                    tiles[i].valueText.text = "10";
                    break;

                case "R":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "R";
                    tiles[i].valueText.text = "1";
                    break;

                case "S":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "S";
                    tiles[i].valueText.text = "1";
                    break;

                case "T":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "T";
                    tiles[i].valueText.text = "1";
                    break;

                case "U":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "U";
                    tiles[i].valueText.text = "1";
                    break;

                case "V":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "V";
                    tiles[i].valueText.text = "4";
                    break;

                case "W":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "W";
                    tiles[i].valueText.text = "4";
                    break;

                case "X":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "X";
                    tiles[i].valueText.text = "8";
                    break;

                case "Y":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "Y";
                    tiles[i].valueText.text = "4";
                    break;

                case "Z":
                    tiles[i].background.color = Color.white;
                    tiles[i].faceText.text = "Z";
                    tiles[i].valueText.text = "10";
                    break;

                default:
                    tiles[i].background.color = new Color(0.5f, 0.5f, 0.5f, 1);
                    tiles[i].faceText.text = "";
                    tiles[i].valueText.text = "";
                    break;
            }
        }
    }
}
