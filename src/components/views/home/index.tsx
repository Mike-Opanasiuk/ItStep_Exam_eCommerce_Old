import { FC } from "react";
import { Link } from "react-router-dom";
import { Card } from "./card";

const products = {
   electronics: [
      {
         name: "Lorem, ipsum dolor.",
         picture: "https://images.samsung.com/is/image/samsung/p6pim/pl/lf27t350fhrxen/gallery/pl-t35f-363583-lf27t350fhrxen-403431628?$720_576_PNG$",
         price: 12
      },
      {
         name: "Lorem, ipsum dolor.",
         picture: "https://images.prismic.io/frameworkmarketplace/cca31de3-3b75-4932-af96-7646b7eba6c7__DSC3630-Edit-cropped.jpg?auto=compress,format",
         price: 123
      },
      {
         name: "Lorem, ipsum dolor sit.",
         picture: "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6402/6402202ld.jpg",
         price: 15
      },
      {
         name: "Lorem.",
         picture: "https://www.marshallheadphones.com/on/demandware.static/-/Sites-zs-master-catalog/default/dw91dd943d/images/marshall/headphones/major-iv/high-res/pos-marshall-major-iv-black-01.png",
         price: 80
      },
      {
         name: "Logitech Craft Keyboard",
         picture: "https://img.pccomponentes.com/articles/18/188501/a7.jpg",
         price: 65
      },
   ],
   garden: [
      {
         name: "Lorem, ipsum dolor.",
         picture: "https://shishkaproject.com/image/cache/data/odb-price-ua-xlsx/odb-konus-10-1-800x800.jpg",
         price: 12
      },
      {
         name: "Lorem, ipsum dolor.",
         picture: "https://aquabud.com.ua/wp-content/uploads/2020/02/800px_88.006.jpg",
         price: 123
      },
      {
         name: "Lorem, ipsum dolor sit.",
         picture: "https://pomidorka.com.ua/8286-tm_thickbox_default/vazon-gloriya-s-podstavkoj-14514-sm.jpg",
         price: 15
      },
      {
         name: "Lorem.",
         picture: "https://vazon.ru/upload/iblock/5da/5dae5f134cc4f0ac00c546989364d2d3.jpg",
         price: 80
      },
      {
         name: "Lorem, ipsum dolor.",
         picture: "https://his.ua/img/products/cU-m_MtRBX_500_500.jpg",
         price: 65
      },
   ]
}

export const HomeView: FC = () => {
   return (
      <div className="py-4">
         <div className="flex gap-4">
            <a href="catalog.html" className="flex-1">
               <img className="object-cover" src="https://i.ytimg.com/vi/l_56hZVOGnI/maxresdefault.jpg" />
               <div className="flex justify-between items-center mt-1">
                  <span className="font-medium text-2xl">Samsung UHD TV</span>
                  <span className="text-2xl">$1230</span>
               </div>
            </a>
            <div className="w-2/5 grid grid-cols-2">
               <Link to="/goods" className="flex flex-col">
                  <img
                     className="w-full h-48 object-cover"
                     src="https://www.amosale.com/wp-content/uploads/2022/02/61IJBsHm97L._SL1500_-2.jpg"
                  />
                  <span className="text-center font-medium text-lg mt-2">iPhones</span>
               </Link>
               <Link to="/goods" className="flex flex-col row-span-2">
                  <img
                     className="w-full h-[420px] object-cover"
                     src="/preview.jpeg"
                  />
                  <span className="font-medium text-lg text-center mt-4">New collection</span>
               </Link>
               <Link to="/goods" className="flex flex-col">
                  <img
                     className="w-full h-48 object-cover"
                     src="https://media.istockphoto.com/photos/red-headphones-isolated-picture-id835148968?k=20&m=835148968&s=170667a&w=0&h=daLHpdrq22SuLaxOsAYlExZ_ER2E3ccSGKvKml7SUGU="
                  />
                  <span className="text-center font-medium text-lg mt-2">Headphones</span>
               </Link>
            </div>
         </div>

         <h2 className="mt-10 text-2xl font-medium text-gray-700">Єлектроніка</h2>
         <div className="grid grid-cols-5 mt-4 gap-4">
            {products.electronics.map((product, index) => (
               <Card key={index} {...product} />
            ))}
         </div>

         <h2 className="mt-8 text-2xl font-medium text-gray-700">Сад та город</h2>
         <div className="grid grid-cols-5 mt-4 gap-4">
            {products.garden.map((product, index) => (
               <Card key={index} {...product} />
            ))}
         </div>
      </div>
   )
}