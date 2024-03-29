using UnityEngine;

public class ItemBaseScript : MonoBehaviour //List of variables for an item object
{
    public ItemTypes itemTypes; //Reference to the SO that makes it possible for an item to have a type
    public ItemTypes.ItemType itemType; //Allows to pick the type of the item in the Inspector
    public int itemValue; //Value increases the score
    public Sprite itemIcon; //Item icon that is passed to the Crafting Station to show what item is inside it
}
