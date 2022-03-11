
singleton TSShapeConstructor(Cork_oak_mediumDae)
{
   baseShape = "./cork_oak_medium.dae";
};

function Cork_oak_mediumDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "0", "0");
}
