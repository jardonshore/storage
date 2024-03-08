  public static UsableType[] GetUsableTypeArray (Type[] types, params UsableType[] additionalUsableTypes)
        {
            List<UsableType> usableTypeList = new List<UsableType> ();
            for (int i = 0; i < types.Length; i++)
            {
                usableTypeList.Add (new UsableType (types[i]));
            }
            usableTypeList.AddRange (additionalUsableTypes);
            return usableTypeList.ToArray ();
        }

        public static UsableType[] AmalgamateUsableTypes (UsableType[] usableTypeArray, params UsableType[] usableTypes)
        {
            List<UsableType> usableTypeList = new List<UsableType> ();//good
            for (int i = 0; i < usableTypes.Length; i++)
            {
                usableTypeList.Add (usableTypes[i]);
            }
            usableTypeList.AddRange(usableTypeArray);
            return usableTypeList.ToArray();
        }

public class LightControlBehaviour : PlayableBehaviour
{
    public Color color = Color.white;
    public float intensity = 1f;
    public float bounceIntensity = 1f;
    public float range = 10f;
}
//hi
