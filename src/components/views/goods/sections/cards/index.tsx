import { FC } from "react";
import { Card } from "./card";

const products = [
   {
      name: "Basic white t-shirt",
      picture: "preview.jpeg",
      price: 7.99
   },
   {
      name: "Basic white t-shirt",
      picture: "preview.jpeg",
      price: 7.99
   },
   {
      name: "Basic white t-shirt",
      picture: "preview.jpeg",
      price: 7.99
   },
   {
      name: "Basic white t-shirt",
      picture: "preview.jpeg",
      price: 7.99
   },
   {
      name: "Basic white t-shirt",
      picture: "preview.jpeg",
      price: 7.99
   },
   {
      name: "Basic white t-shirt",
      picture: "preview.jpeg",
      price: 7.99
   },
   {
      name: "Basic white t-shirt",
      picture: "preview.jpeg",
      price: 7.99
   },
   {
      name: "Basic white t-shirt",
      picture: "preview.jpeg",
      price: 7.99
   }
];

export const CardsSection: FC = () => {
   return (
      <div className="grid grid-cols-4 gap-2 mt-4">
         {products.map((product, index) => (
            <Card key={index} {...product} />
         ))}
      </div>
   )
}