import { Quantity } from "@layout/quantity";
import { FC } from "react";
import { Link } from "react-router-dom";
import { uid } from "uid";

const products = [
   {
      id: uid(6),
      name: "Basic white t-shirt",
      quantity: 1,
      price: 12.99
   },
   {
      id: uid(6),
      name: "Black t-shirt",
      quantity: 2,
      price: 14
   },
   {
      id: uid(6),
      name: "Basic navy t-shirt",
      quantity: 7,
      price: 14.50
   }
]

export const CartView: FC = () => {
   return (
      <div className="py-4 mx-auto max-w-4xl px-8 flex flex-col-reverse md:flex-row md:items-start gap-8">
         {/* <!-- Products section --> */}
         <div className="space-y-4 flex-1">
            {products.map((product, index) => (
               <div key={index} className="flex items-center gap-x-5">
                  <img className="shadow-sm rounded w-20 h-20 sm:w-28 sm:h-28 object-cover" src="/preview.jpeg" />
                  {/* <!-- Description --> */}
                  <div className="flex-1 space-y-4">
                     <Link
                        to={`/product/${product.id}`}
                        className="font-medium transition border-b border-transparent hover:border-gray-300"
                     >
                        {product.name}
                     </Link>
                     <div className="flex flex-wrap justify-between">
                        <span className="text-2xl text-gray-500">${product.price}</span>
                        <Quantity />
                     </div>
                  </div>
               </div>
            ))}
         </div>
         {/* <!-- Order section --> */}
         <div
            className="pl-5 pb-8 md:p-8 border-b md:border md:w-72 flex items-center justify-between md:block"
         >
            <span className="text-gray-400 text-xl hidden md:block">Order</span>
            <ul className="text mt-4 hidden md:block">
               {products.map((product, index) => (
                  <li key={index} className="flex items-center">
                     <span className="text-gray-800">{product.name}</span>
                     <span className="text-xs ml-auto font-medium text-gray-700">x{product.quantity}</span>
                  </li>
               ))}
            </ul>
            <div className="flex md:mt-4 items-center text-2xl text-gray-700">
               <span>Rest:</span>
               <span className="ml-4 md:ml-auto text-gray-500">$109</span>
            </div>
            <button
               className="px-8 md:w-full md:mt-4 py-4 bg-black text-white"
            >
               Checkout
            </button>
         </div>
      </div>
   );
};