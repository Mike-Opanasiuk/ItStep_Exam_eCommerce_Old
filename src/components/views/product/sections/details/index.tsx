import { FC } from "react";
import { Form, FormResultValues } from "@base/form";
import { BreadCrumbs } from "@layout/bread-crumbs";
import { HorizontalSelect } from "./horizontal-select";
import { Quantity } from "@layout/quantity";

const bread_data = [
   { name: "Товари", link: "/goods" },
   { name: "Одяг", link: "/goods" },
   { name: "Жіночий", link: "/goods" },
   { name: "Футболки", link: "/goods" },
];

const filters = [
   { name: "brand", title: "Бренд", link: { name: "Zara", href: "/goods" } },
   {
      name: "color", title: "Колір",
      select: [
         { name: "Білий", value: "white", prefix: <div className="w-2 h-2 bg-[white] border rounded-full"></div> },
         { name: "Чорний", value: "black", prefix: <div className="w-2 h-2 bg-black rounded-full"></div> },
         { name: "Синій", value: "navy", prefix: <div className="w-2 h-2 bg-[navy] rounded-full"></div> },
         { name: "Рожевий", value: "pink", prefix: <div className="w-2 h-2 bg-[pink] rounded-full"></div> },
      ]
   },
   { name: "material", title: "Матеріал", link: { name: "Текстиль", href: "/goods" } },
   {
      name: "size", title: "Розмір",
      select: [
         { name: "S", value: "s" },
         { name: "M", value: "m" },
         { name: "L", value: "l" },
         { name: "XL", value: "xl" },
         { name: "XXL", value: "xxl" },
         { name: "XXXL", value: "xxxl" },
      ]
   }
];

export const Details: FC = () => {

   const handleFormFinish = (values: FormResultValues) => {

   }

   return (
      <div>
         <h1 className="text-3xl font-medium mb-6">Basic white t-shirt</h1>
         <BreadCrumbs options={bread_data} />
         <p className="mt-6">
            Lorem ipsum dolor sit amet consectetur, adipisicing elit. Laborum
            repellendus dicta quidem, magni in fugit?
         </p>
         <Form onFinish={handleFormFinish}>
            <ul className="mt-8 space-y-6">
               {filters.map(({ link, select, name, title }, index) => (
                  <li key={index} className="flex justify-between items-center">
                     <span className="text-gray-600">{title}:</span>
                     {link && (
                        <a href={link.href} className="font-medium hover:underline">{link.name}</a>
                     )}
                     {select && (
                        <HorizontalSelect name={name} options={select} />
                     )}
                  </li>
               ))}
               <li className="flex justify-between items-center">
                  <span className="text-lg">Кількість:</span>
                  <Quantity />
               </li>
            </ul>
            <div className="mt-8 flex justify-between items-center">
               <span className="text-2xl">$15.99</span>
               <button className="text-white bg-black py-4 px-8">Add to Cart</button>
            </div>
         </Form>
         <ul className="mt-8 space-y-4">
            <li className="bg-slate-50">
               <div className="flex justify-between items-center">
                  <span>Стиль:</span>
                  <span className="text-lg text-gray-500">Casual</span>
               </div>
               <p className="mt-2 text-sm">
                  Lorem ipsum dolor sit amet consectetur adipisicing elit. Hic
                  consequuntur ad, animi temporibus neque assumenda.
               </p>
            </li>
            <li className="bg-pink-50">
               <div className="flex justify-between items-center">
                  <span>Розміри:</span>
                  <span className="text-lg text-gray-500">S, M, L, XL, XXL, XXXL</span>
               </div>
               <p className="mt-2 text-sm">
                  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ipsa!
               </p>
               <p className="mt-2 text-sm">
                  Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt
                  doloribus fugiat officia consequatur recusandae!
               </p>
            </li>
         </ul>
      </div>
   );
};